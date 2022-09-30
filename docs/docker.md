# Docker Commands

### CREATE IMAGE

```shell
docker build -t acrbucketdev.azurecr.io/bucket:1 .
```

### TAG IMAGE

OPTIONAL: When a docker image is created without a version tag, its useful to use the following syntax to tag a local image.

```shell
docker tag bucket acrbucketdev.azurecr.io/bucket:1
```

### Run container locally

```shell
docker run -d -p 5000:5000 acrbucketdev.azurecr.io/bucket:1
```
