dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/tryAGI/HuggingFace/8de69e61e12b762f24d1acbe844ed855267bcf60/docs/openapi.yaml
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
autosdk generate openapi.yaml \
  --namespace HuggingFace \
  --clientClassName HuggingFaceApi \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations