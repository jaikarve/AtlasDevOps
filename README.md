# A simple example to show how to deploy Atlas Cluster using Azure DevOps and Terraform provider

### Fork this repo

## Setup Azure DevOps Organization and project

### Navigate to Project, Choose Pipelines

### Choose Create Pipeline

### Where is your code - Choose Github

### Choose repo you forked in previous step, It will load the azure-pipelines.yml file

#### Create Following variables
![Edit Variables](/img/variables.png)

1. $(ContainerName)
2. $(ResourceGroupName)
3. $(StorageAccountName)

#### Update yml file value (Use the value of backendserviceArm template)
##### backendServiceArm: 'Visual Studio Enterprise (62626e97-807f-4c32-98e6-b7c3078adaf9)'

#### Configure Atlas API Acces following these links

https://docs.atlas.mongodb.com/configure-api-access/

#### Ensure IPs of Azure region of your microsoft hosted or self hosted agent is whitelisted in the Atlas programmatic key created above

#### Go to Library of left hand navigation
![Library](/img/Library-Securefile.png)
#### upload terraform.tfvars file with following values

> public_key = "<Your Atlas Public Key>"
>
> private_key  = "<Your Atlas Private Key>"
>
> atlasprojectid = "<Atlas project Id>"
>
> cluster_region = "US_WEST_2"
>
> atlas_provider_name = "AWS"
>
> atlas_provider_instance_size_name = "M10"
>
> auto_scaling_disk_gb_enabled = true
>
> mongo_db_major_version       = "4.4"
>
> mongodb_atlas_database_username = "<username you want to use>"
>
> mongodb_atlas_database_user_password = "<password you want to use>"


#### Click on terrafornm.tvars file name can choose Pipeline Permissions - Authorize for use in all pipelines (Else you will be asked to permit when you run the piepline first time)

![Authorize secure file](/img/AuthorizeSecureFile.png)

#### After this, Come back to pipelines and say run pipeline to trigger it manually

![Pipeline running](/img/ADO-Atlas-tf-create.png)

