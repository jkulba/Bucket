# Azure Commands

[Azure Container Tutorial](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-tutorial-prepare-app)

CREATE RESOURCE GROUP

```shell
az group create --name rgbucketdev --location westus
```

[Azure Container Registry Tutorial](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-tutorial-prepare-acr)

CREATE AZURE CONTAINER REGISTRY

```shell
az acr create --resource-group rgbucketdev --name acrbucketdev --sku Basic
```

LOG IN

```shell
az acr login --name acrbucketdev
```

```shell
az acr show --name acrbucketdev --query loginServer --output table
```

Result

acrbucketdev.azurecr.io
