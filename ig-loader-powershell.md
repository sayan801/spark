$serverUrl = "http://localhost:5000/fhir" # Change to your server URL
$resourceFolder = "C:\Path\To\Your\IG\resources" # Change to your IG resource folder

Get-ChildItem -Path $resourceFolder -Filter *.json | ForEach-Object {
    $file = $_.FullName
    $json = Get-Content $file -Raw
    $resourceType = (ConvertFrom-Json $json).resourceType
    $url = "$serverUrl/$resourceType"
    Write-Host "Uploading $file to $url"
    Invoke-RestMethod -Uri $url -Method Post -Body $json -ContentType "application/fhir+json"
}