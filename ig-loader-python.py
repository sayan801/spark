import os
import requests
import json

server_url = "http://localhost:5000/fhir"  # Change to your server URL
resource_folder = r"C:\Path\To\Your\IG\resources"  # Change to your IG resource folder

for filename in os.listdir(resource_folder):
    if filename.endswith(".json"):
        file_path = os.path.join(resource_folder, filename)
        with open(file_path, "r", encoding="utf-8") as f:
            resource = json.load(f)
        resource_type = resource.get("resourceType")
        if not resource_type:
            print(f"Skipping {filename}: No resourceType found.")
            continue
        url = f"{server_url}/{resource_type}"
        print(f"Uploading {filename} to {url}")
        response = requests.post(url, json=resource, headers={"Content-Type": "application/fhir+json"})
        print(f"Status: {response.status_code} - {response.reason}")