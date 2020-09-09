## Project to get IPs for Azure Agent host to whitelist in Atlas (For example CentralUS below)

> https://docs.microsoft.com/en-us/azure/devops/pipelines/agents/hosted?view=azure-devops&tabs=yaml#agent-ip-ranges

```
curl --user "{PUBLIC-KEY}:{PRIVATE-KEY}" --digest \
--request POST 'https://cloud.mongodb.com/api/atlas/v1.0/orgs/{ORG-ID}/apiKeys/{API-KEY-ID}/whitelist' \
--header 'Accept: application/json' \
--header 'Content-Type: application/json' \
--data-raw '[
    {
        "ipAddress": "13.67.128.0/20"
    },
    {
        "ipAddress": "13.67.144.0/21"
    },
    {
        "ipAddress": "13.67.152.0/24"
    },
    {
        "ipAddress": "13.67.153.0/28"
    },
    {
        "ipAddress": "13.67.153.32/27"
    },
    {
        "ipAddress": "13.67.153.64/26"
    },
    {
        "ipAddress": "13.67.153.128/25"
    },
    {
        "ipAddress": "13.67.155.0/24"
    },
    {
        "ipAddress": "13.67.156.0/22"
    },
    {
        "ipAddress": "13.67.160.0/19"
    },
    {
        "ipAddress": "13.67.192.0/18"
    },
    {
        "ipAddress": "13.86.0.0/17"
    },
    {
        "ipAddress": "13.89.0.0/16"
    },
    {
        "ipAddress": "13.104.147.128/25"
    },
    {
        "ipAddress": "13.104.219.128/25"
    },
    {
        "ipAddress": "13.105.17.192/26"
    },
    {
        "ipAddress": "13.105.24.0/24"
    },
    {
        "ipAddress": "13.105.37.0/26"
    },
    {
        "ipAddress": "13.105.53.192/26"
    },
    {
        "ipAddress": "20.37.128.0/18"
    },
    {
        "ipAddress": "20.38.96.0/23"
    },
    {
        "ipAddress": "20.38.122.0/23"
    },
    {
        "ipAddress": "20.40.192.0/18"
    },
    {
        "ipAddress": "20.44.8.0/21"
    },
    {
        "ipAddress": "20.46.224.0/19"
    },
    {
        "ipAddress": "20.47.58.0/23"
    },
    {
        "ipAddress": "20.47.78.0/23"
    },
    {
        "ipAddress": "20.60.18.0/24"
    },
    {
        "ipAddress": "20.60.30.0/23"
    },
    {
        "ipAddress": "20.135.0.0/22"
    },
    {
        "ipAddress": "20.150.43.128/25"
    },
    {
        "ipAddress": "20.150.58.0/24"
    },
    {
        "ipAddress": "20.150.63.0/24"
    },
    {
        "ipAddress": "20.150.77.0/24"
    },
    {
        "ipAddress": "20.150.89.0/24"
    },
    {
        "ipAddress": "20.150.95.0/24"
    },
    {
        "ipAddress": "20.157.34.0/23"
    },
    {
        "ipAddress": "20.184.64.0/18"
    },
    {
        "ipAddress": "20.186.192.0/18"
    },
    {
        "ipAddress": "20.190.134.0/24"
    },
    {
        "ipAddress": "20.190.155.0/24"
    },
    {
        "ipAddress": "23.99.128.0/17"
    },
    {
        "ipAddress": "23.100.80.0/21"
    },
    {
        "ipAddress": "23.100.240.0/20"
    },
    {
        "ipAddress": "23.101.112.0/20"
    },
    {
        "ipAddress": "23.102.202.0/24"
    },
    {
        "ipAddress": "40.67.160.0/19"
    },
    {
        "ipAddress": "40.69.128.0/18"
    },
    {
        "ipAddress": "40.77.0.0/17"
    },
    {
        "ipAddress": "40.77.130.128/26"
    },
    {
        "ipAddress": "40.77.137.0/25"
    },
    {
        "ipAddress": "40.77.138.0/25"
    },
    {
        "ipAddress": "40.77.161.64/26"
    },
    {
        "ipAddress": "40.77.166.192/26"
    },
    {
        "ipAddress": "40.77.171.0/24"
    },
    {
        "ipAddress": "40.77.175.192/27"
    },
    {
        "ipAddress": "40.77.175.240/28"
    },
    {
        "ipAddress": "40.77.182.16/28"
    },
    {
        "ipAddress": "40.77.182.192/26"
    },
    {
        "ipAddress": "40.77.184.128/25"
    },
    {
        "ipAddress": "40.77.197.0/24"
    },
    {
        "ipAddress": "40.77.255.128/26"
    },
    {
        "ipAddress": "40.78.128.0/18"
    },
    {
        "ipAddress": "40.78.221.0/24"
    },
    {
        "ipAddress": "40.82.16.0/22"
    },
    {
        "ipAddress": "40.82.96.0/22"
    },
    {
        "ipAddress": "40.83.0.0/20"
    },
    {
        "ipAddress": "40.83.16.0/21"
    },
    {
        "ipAddress": "40.83.24.0/26"
    },
    {
        "ipAddress": "40.83.24.64/27"
    },
    {
        "ipAddress": "40.83.24.128/25"
    },
    {
        "ipAddress": "40.83.25.0/24"
    },
    {
        "ipAddress": "40.83.26.0/23"
    },
    {
        "ipAddress": "40.83.28.0/22"
    },
    {
        "ipAddress": "40.83.32.0/19"
    },
    {
        "ipAddress": "40.86.0.0/17"
    },
    {
        "ipAddress": "40.87.180.0/30"
    },
    {
        "ipAddress": "40.87.180.4/31"
    },
    {
        "ipAddress": "40.87.182.4/30"
    },
    {
        "ipAddress": "40.87.182.8/29"
    },
    {
        "ipAddress": "40.87.182.24/29"
    },
    {
        "ipAddress": "40.87.182.32/28"
    },
    {
        "ipAddress": "40.87.182.48/29"
    },
    {
        "ipAddress": "40.87.182.56/30"
    },
    {
        "ipAddress": "40.87.182.62/31"
    },
    {
        "ipAddress": "40.87.182.64/26"
    },
    {
        "ipAddress": "40.87.182.128/25"
    },
    {
        "ipAddress": "40.87.183.0/28"
    },
    {
        "ipAddress": "40.87.183.16/29"
    },
    {
        "ipAddress": "40.87.183.24/30"
    },
    {
        "ipAddress": "40.87.183.34/31"
    },
    {
        "ipAddress": "40.87.183.36/30"
    },
    {
        "ipAddress": "40.87.183.42/31"
    },
    {
        "ipAddress": "40.87.183.44/30"
    },
    {
        "ipAddress": "40.87.183.54/31"
    },
    {
        "ipAddress": "40.87.183.56/29"
    },
    {
        "ipAddress": "40.87.183.64/26"
    },
    {
        "ipAddress": "40.87.183.144/28"
    },
    {
        "ipAddress": "40.87.183.160/27"
    },
    {
        "ipAddress": "40.87.183.192/27"
    },
    {
        "ipAddress": "40.87.183.224/29"
    },
    {
        "ipAddress": "40.87.183.232/30"
    },
    {
        "ipAddress": "40.87.183.236/31"
    },
    {
        "ipAddress": "40.87.183.244/30"
    },
    {
        "ipAddress": "40.87.183.248/29"
    },
    {
        "ipAddress": "40.89.224.0/19"
    },
    {
        "ipAddress": "40.90.16.0/27"
    },
    {
        "ipAddress": "40.90.21.128/25"
    },
    {
        "ipAddress": "40.90.22.0/25"
    },
    {
        "ipAddress": "40.90.26.128/25"
    },
    {
        "ipAddress": "40.90.129.224/27"
    },
    {
        "ipAddress": "40.90.130.64/28"
    },
    {
        "ipAddress": "40.90.130.192/28"
    },
    {
        "ipAddress": "40.90.132.192/26"
    },
    {
        "ipAddress": "40.90.137.224/27"
    },
    {
        "ipAddress": "40.90.140.96/27"
    },
    {
        "ipAddress": "40.90.140.224/27"
    },
    {
        "ipAddress": "40.90.141.0/27"
    },
    {
        "ipAddress": "40.90.142.128/27"
    },
    {
        "ipAddress": "40.90.142.240/28"
    },
    {
        "ipAddress": "40.90.144.0/27"
    },
    {
        "ipAddress": "40.90.144.128/26"
    },
    {
        "ipAddress": "40.90.148.176/28"
    },
    {
        "ipAddress": "40.90.149.96/27"
    },
    {
        "ipAddress": "40.90.151.144/28"
    },
    {
        "ipAddress": "40.90.154.64/26"
    },
    {
        "ipAddress": "40.90.156.192/26"
    },
    {
        "ipAddress": "40.90.158.64/26"
    },
    {
        "ipAddress": "40.113.192.0/18"
    },
    {
        "ipAddress": "40.122.16.0/20"
    },
    {
        "ipAddress": "40.122.32.0/19"
    },
    {
        "ipAddress": "40.122.64.0/18"
    },
    {
        "ipAddress": "40.122.128.0/17"
    },
    {
        "ipAddress": "40.126.6.0/24"
    },
    {
        "ipAddress": "40.126.27.0/24"
    },
    {
        "ipAddress": "52.108.165.0/24"
    },
    {
        "ipAddress": "52.108.166.0/23"
    },
    {
        "ipAddress": "52.108.185.0/24"
    },
    {
        "ipAddress": "52.108.208.0/21"
    },
    {
        "ipAddress": "52.109.8.0/22"
    },
    {
        "ipAddress": "52.111.227.0/24"
    },
    {
        "ipAddress": "52.112.113.0/24"
    },
    {
        "ipAddress": "52.113.129.0/24"
    },
    {
        "ipAddress": "52.114.128.0/22"
    },
    {
        "ipAddress": "52.115.76.0/22"
    },
    {
        "ipAddress": "52.115.80.0/22"
    },
    {
        "ipAddress": "52.115.88.0/22"
    },
    {
        "ipAddress": "52.125.128.0/22"
    },
    {
        "ipAddress": "52.136.30.0/24"
    },
    {
        "ipAddress": "52.141.192.0/19"
    },
    {
        "ipAddress": "52.141.240.0/20"
    },
    {
        "ipAddress": "52.143.193.0/24"
    },
    {
        "ipAddress": "52.143.224.0/19"
    },
    {
        "ipAddress": "52.154.0.0/18"
    },
    {
        "ipAddress": "52.154.128.0/17"
    },
    {
        "ipAddress": "52.158.160.0/20"
    },
    {
        "ipAddress": "52.158.192.0/19"
    },
    {
        "ipAddress": "52.165.0.0/19"
    },
    {
        "ipAddress": "52.165.32.0/20"
    },
    {
        "ipAddress": "52.165.48.0/28"
    },
    {
        "ipAddress": "52.165.49.0/24"
    },
    {
        "ipAddress": "52.165.56.0/21"
    },
    {
        "ipAddress": "52.165.64.0/19"
    },
    {
        "ipAddress": "52.165.96.0/21"
    },
    {
        "ipAddress": "52.165.104.0/25"
    },
    {
        "ipAddress": "52.165.128.0/17"
    },
    {
        "ipAddress": "52.173.0.0/16"
    },
    {
        "ipAddress": "52.176.0.0/17"
    },
    {
        "ipAddress": "52.176.128.0/19"
    },
    {
        "ipAddress": "52.176.160.0/21"
    },
    {
        "ipAddress": "52.176.176.0/20"
    },
    {
        "ipAddress": "52.176.192.0/19"
    },
    {
        "ipAddress": "52.176.224.0/24"
    },
    {
        "ipAddress": "52.180.128.0/19"
    },
    {
        "ipAddress": "52.180.184.0/27"
    },
    {
        "ipAddress": "52.180.184.32/28"
    },
    {
        "ipAddress": "52.180.185.0/24"
    },
    {
        "ipAddress": "52.182.128.0/17"
    },
    {
        "ipAddress": "52.185.0.0/19"
    },
    {
        "ipAddress": "52.185.32.0/20"
    },
    {
        "ipAddress": "52.185.48.0/21"
    },
    {
        "ipAddress": "52.185.56.0/26"
    },
    {
        "ipAddress": "52.185.56.64/27"
    },
    {
        "ipAddress": "52.185.56.96/28"
    },
    {
        "ipAddress": "52.185.56.128/27"
    },
    {
        "ipAddress": "52.185.56.160/28"
    },
    {
        "ipAddress": "52.185.64.0/19"
    },
    {
        "ipAddress": "52.185.96.0/20"
    },
    {
        "ipAddress": "52.185.112.0/26"
    },
    {
        "ipAddress": "52.185.112.96/27"
    },
    {
        "ipAddress": "52.185.120.0/21"
    },
    {
        "ipAddress": "52.189.0.0/17"
    },
    {
        "ipAddress": "52.228.128.0/17"
    },
    {
        "ipAddress": "52.230.128.0/17"
    },
    {
        "ipAddress": "52.232.157.0/24"
    },
    {
        "ipAddress": "52.238.192.0/18"
    },
    {
        "ipAddress": "52.239.150.0/23"
    },
    {
        "ipAddress": "52.239.177.32/27"
    },
    {
        "ipAddress": "52.239.177.64/26"
    },
    {
        "ipAddress": "52.239.177.128/25"
    },
    {
        "ipAddress": "52.239.195.0/24"
    },
    {
        "ipAddress": "52.239.234.0/23"
    },
    {
        "ipAddress": "52.242.128.0/17"
    },
    {
        "ipAddress": "52.245.68.0/24"
    },
    {
        "ipAddress": "52.245.69.32/27"
    },
    {
        "ipAddress": "52.245.69.64/27"
    },
    {
        "ipAddress": "52.245.69.96/28"
    },
    {
        "ipAddress": "52.245.69.144/28"
    },
    {
        "ipAddress": "52.245.69.160/27"
    },
    {
        "ipAddress": "52.245.69.192/26"
    },
    {
        "ipAddress": "52.245.70.0/23"
    },
    {
        "ipAddress": "52.255.0.0/19"
    },
    {
        "ipAddress": "65.55.144.0/23"
    },
    {
        "ipAddress": "65.55.146.0/24"
    },
    {
        "ipAddress": "104.43.128.0/17"
    },
    {
        "ipAddress": "104.44.88.160/27"
    },
    {
        "ipAddress": "104.44.91.160/27"
    },
    {
        "ipAddress": "104.44.92.224/27"
    },
    {
        "ipAddress": "104.44.94.80/28"
    },
    {
        "ipAddress": "104.208.0.0/19"
    },
    {
        "ipAddress": "104.208.32.0/20"
    },
    {
        "ipAddress": "131.253.36.224/27"
    },
    {
        "ipAddress": "157.55.108.0/23"
    },
    {
        "ipAddress": "168.61.128.0/25"
    },
    {
        "ipAddress": "168.61.128.128/28"
    },
    {
        "ipAddress": "168.61.128.160/27"
    },
    {
        "ipAddress": "168.61.128.192/26"
    },
    {
        "ipAddress": "168.61.129.0/25"
    },
    {
        "ipAddress": "168.61.129.128/26"
    },
    {
        "ipAddress": "168.61.129.208/28"
    },
    {
        "ipAddress": "168.61.129.224/27"
    },
    {
        "ipAddress": "168.61.130.64/26"
    },
    {
        "ipAddress": "168.61.130.128/25"
    },
    {
        "ipAddress": "168.61.131.0/26"
    },
    {
        "ipAddress": "168.61.131.128/25"
    },
    {
        "ipAddress": "168.61.132.0/26"
    },
    {
        "ipAddress": "168.61.144.0/20"
    },
    {
        "ipAddress": "168.61.160.0/19"
    },
    {
        "ipAddress": "168.61.208.0/20"
    },
    {
        "ipAddress": "193.149.72.0/21"
    }
]'
```
