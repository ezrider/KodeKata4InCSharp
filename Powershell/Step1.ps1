# pre process file for empty lines
$filepath = "C:\Users\\mbeaulieu1\\Documents\\GitHub\\KodeKata4InCSharp\\Data\\weather.dat"

$newfilepath = "C:\Users\\mbeaulieu1\\Documents\\GitHub\\KodeKata4InCSharp\\Data\\file.txt"

(gc $filepath) | ? {$_.trim() -ne "" } | set-content $newfilepath

#Use PowerShell’s Import-Csv cmdlet to import structured data from a CSV file. 
#Use the -Delimiter parameter if fields are separated by a character other than a comma.
$data = Import-csv  $newfilepath -Delimiter  " " -

$data
$lines = Get-Content $flepath
foreach ($line in $lines){
    $fields = $line -split '\s+'
    $fields[2]
}
$lines[0]
$columnheaders = $lines[0] -split '\s+'
foreach ($col in $columnheaders){

$col
}
