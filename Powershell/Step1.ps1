# pre process file for empty lines

<#

Download this text file, 
then write a program 
to output the day number (column one) 
with the smallest temperature spread 
(the maximum temperature is the second column, 
the minimum the third column).


Step 1 - to clean the data - done with $newfilepath2
Step 2 - loop through the column data


notes:
first version throwaway
==========================================
# play around using the raw file handling
$lines = Get-Content $filepath
foreach ($line in $lines){
    $fields = $line -split '\s+'
}
$columnheaders = $lines[0] -split '\s+'
foreach ($col in $columnheaders){
#$col
}
==========================================
#>
$results= @{}

$filepath = "C:\Users\\mbeaulieu1\\Documents\\GitHub\\KodeKata4InCSharp\\Data\\weather.dat"
$newfilepath = "C:\Users\mbeaulieu1\Documents\GitHub\KodeKata4InCSharp\Data\file.txt"
$newfilepath2 = "C:\Users\mbeaulieu1\Documents\GitHub\KodeKata4InCSharp\Data\file2.txt"

#ii $newfilepath

gc $filepath | ForEach-Object {$_.trim() } | set-content $newfilepath


(gc $newfilepath) | ? {$_.trim() -ne "" } | set-content $newfilepath


 
 (gc $newfilepath) |  ForEach-Object {
            while ($_.contains("  ")){
                $_ = $_ -replace "  ", " "
                }
            $_ -replace "\s","," 
                } |  
 set-content $newfilepath2
 
# ii $newfilepath
# ii $newfilepath2

#Use PowerShell’s Import-Csv cmdlet to import structured data from a CSV file. 
#Use the -Delimiter parameter if fields are separated by a character other than a comma.
$data = Import-csv  $newfilepath2 
#$data
#$data | select  Dy, MxT, MnT, AvT
#$data | get-member

#$data[0] | get-member



foreach ($l in $data){
    # check the results - if null add a record
    #If current line spread is greater or equal to the existing max then add the line number
    
    # check that all values are numbers
    $spread = $l.MxT - $l.MnT
           
}



