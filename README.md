# exchangerateapi
.Net5 WebApi Application

# Instructions
Simplest way to test is by running the application locally using VS. Use Swagger to test the only endpoint :)

Parameters:
Dates: list of dates in the yyyy-mm-dd format
BaseCurrency (optional): default EUR
ConversionCurrency (optional): default SEK

# Improvements
Unfortunately this solution calls the exchangerate.host Api for every date parameter which is not optimal. If I had time I would try to 
minimize the number of calls by using the time-series data endpoint on exchangerate.host api. 

Also I would use cache using each date together with baseCurrency as cache key in order to access the data faster in the future

Add better request and response validation, logging and error handling