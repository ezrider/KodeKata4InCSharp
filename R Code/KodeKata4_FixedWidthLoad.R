filepath2 <- "~/GitHub/KodeKata4InCSharp/Data/weather.dat"
filepath <- "../Data/weather.dat"
fields = c( 4, 6,6, 6,6,6, 5,  6, 7,5, 5, 4, 5, 5,4,3,6 )

records <- read.fwf(filepath2, widths=fields)
