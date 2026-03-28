#!/usr/bin/env bash
set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.json.tmp https://huggingface.co/.well-known/openapi.json && mv openapi.json.tmp openapi.json || echo "Warning: Failed to download openapi.json, using existing file"

# Fix enum values that break C# code generation (embedded quotes, emojis)
python3 << 'PYEOF'
import json, unicodedata

EMOJI_MAP = {
    "\U0001f525": "fire", "\U0001f680": "rocket", "\U0001f440": "eyes",
    "\u2764\ufe0f": "heart", "\U0001f917": "hugs", "\U0001f60e": "cool",
    "\u2795": "plus", "\U0001f9e0": "brain", "\U0001f44d": "thumbsup",
    "\U0001f91d": "handshake", "\U0001f614": "sad", "\U0001f92f": "mindblown",
}

def fix_properties(obj):
    """Remove _prefixed properties when non-prefixed variant exists."""
    if isinstance(obj, dict):
        if 'properties' in obj and isinstance(obj['properties'], dict):
            props = obj['properties']
            keys = set(props.keys())
            to_remove = [k for k in keys if k.startswith('_') and k[1:] in keys]
            for k in to_remove:
                del props[k]
            if 'required' in obj and isinstance(obj['required'], list):
                obj['required'] = [r for r in obj['required'] if r not in to_remove]
        for v in obj.values():
            fix_properties(v)
    elif isinstance(obj, list):
        for item in obj:
            fix_properties(item)

def fix_enum_value(s):
    if not isinstance(s, str):
        return s
    s = s.replace('"', "'")
    for emoji, name in EMOJI_MAP.items():
        s = s.replace(emoji, name)
    return s

def fix_enums(obj):
    if isinstance(obj, dict):
        for k, v in obj.items():
            if k == 'enum' and isinstance(v, list):
                obj[k] = [fix_enum_value(s) for s in v]
            else:
                fix_enums(v)
    elif isinstance(obj, list):
        for item in obj:
            fix_enums(item)

with open('openapi.json', 'r') as f:
    spec = json.load(f)
fix_enums(spec)
fix_properties(spec)
with open('openapi.json', 'w') as f:
    json.dump(spec, f, separators=(',', ':'))
PYEOF

autosdk generate openapi.json \
  --namespace HuggingFace \
  --clientClassName HuggingFaceClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# Generate Inference API client from TGI (Text Generation Inference) spec
curl --fail --silent --show-error -o tgi-openapi.json \
  https://raw.githubusercontent.com/huggingface/text-generation-inference/main/docs/openapi.json

# Fix OpenAPI 3.1 features in TGI spec that AutoSDK's 3.0 parser can't handle
python3 << 'PYEOF'
import json

def fix_exclusive_bounds(obj):
    """Convert 3.1-style exclusiveMinimum/Maximum (numeric) to 3.0-style (boolean)."""
    if isinstance(obj, dict):
        for key in ('exclusiveMinimum', 'exclusiveMaximum'):
            if key in obj and isinstance(obj[key], (int, float)):
                bound_key = 'minimum' if key == 'exclusiveMinimum' else 'maximum'
                # Only set the bound if not already present
                if bound_key not in obj:
                    obj[bound_key] = obj[key]
                obj[key] = True
        for v in obj.values():
            fix_exclusive_bounds(v)
    elif isinstance(obj, list):
        for item in obj:
            fix_exclusive_bounds(item)

with open('tgi-openapi.json', 'r') as f:
    spec = json.load(f)
fix_exclusive_bounds(spec)
with open('tgi-openapi.json', 'w') as f:
    json.dump(spec, f, separators=(',', ':'))
PYEOF

autosdk generate tgi-openapi.json \
  --namespace HuggingFace \
  --clientClassName HuggingFaceInferenceClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://router.huggingface.co \
  --security-scheme Http:Header:Bearer
rm tgi-openapi.json

# Generate Embeddings API client from TEI (Text Embeddings Inference) spec
curl --fail --silent --show-error -o tei-openapi.json \
  https://raw.githubusercontent.com/huggingface/text-embeddings-inference/main/docs/openapi.json
autosdk generate tei-openapi.json \
  --namespace HuggingFace \
  --clientClassName HuggingFaceEmbeddingClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --base-url https://router.huggingface.co \
  --security-scheme Http:Header:Bearer
rm tei-openapi.json
