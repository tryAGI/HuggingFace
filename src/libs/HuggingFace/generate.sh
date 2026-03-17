set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.json https://huggingface.co/.well-known/openapi.json
autosdk generate openapi.json \
  --namespace HuggingFace \
  --clientClassName HuggingFaceClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
