

$lines = Get-Content "C:\Users\\mbeaulieu1\\Documents\\GitHub\\KodeKata4InCSharp\\Data\\weather.dat"
foreach ($line in $lines){
    $fields = $line -split '\s+'
    $fields[2]
}
$lines[0]
$columnheaders = $lines[0] -split '\s+'
foreach ($col in $columnheaders){

$col
}
