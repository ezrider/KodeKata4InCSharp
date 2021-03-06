#RosettaCode Data Munging Code

$dateHash = @{}
$goodLineCount = 0

$scriptpath = $MyInvocation.MyCommand.Path
$dir = Split-Path $scriptpath
Write-host "My directory is $dir"


$mydatafile = $dir + '\..\data\readings.txt'

# Example of PowerShell Loop
$NumArray = (1..24)
#Foreach ($Item in $NumArray) {$Item * 13}

$cols = @()
$cols += 'Date'

foreach ($e in $NumArray){
$cols += 'col'+$e
}

#$cols

$data = Import-csv  $mydatafile -Delimiter  "`t" -header $cols 
write-host "There are $($data.count) lines"


foreach ($line in $data){
    if ($dateHash.containskey($line.Date)) {
            $line.Date + " is duplicated"
        } else {
            $dateHash.add($line.Date, $line)
        }
        
    #$goodLine = $true
    #if ($line.count -ne 49) { $goodLine = $false; "incorrect line length : $line"  }

        
#write-host " This is date $($line.Date) on with Data1 $($line.col1)"

}

$dateHash.Values | select -First 5 Date



#$fields = $data[1] -split '\s+'
#$fields[0..2]