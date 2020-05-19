# immedia
asp.net core web api rest services with mvc front end to get venues and photos from Foursquare API

Step 1: Install Nuget Solution Packages        
---------------------------------------
        1. Newtonsoft.Json
        2. Microsoft.EntityFrameworkCore
        3. Microsoft.EntityFrameworkCore.Design
        4. Microsoft.EntityFrameworkCore.SqlServer
        5. Microsoft.EntityFrameworkCore.Tools
        
Step 2: Run DB Migration Commands
---------------------------------
1. add-migration "initialmigration"
2. update-database

Step 3: Run API solution and WebApp both simultaneously
-------------------------------------------------------


Additional Information:


API End Points:
--------------

1. Get Landmarks or Venues 

https://localhost:44395/api/landmark/getbyplace/durban

OR

https://localhost:44395/api/landmark/getbyplace/-29.84687587107469/31.007350219458488

2. Get Photos for Venue 

https://localhost:44395/api/landmark/getphotos/4b93823cf964a5206b4634e3

2. Get Details for Photo 

https://localhost:44395/api/landmark/getphotodetails/4ff40728e4b0b8fda8b7fe49


Foursquare Resources Used:
-------------------------
v=20200511
client_id=T1QHICJK4NPR3RZWWRRV3YZY5YL3QJKHVLMKRX0B1YYL0AIY
client_secret=XK0Q3KYJOSN51XTTRZDJ1JWNYOEHDXVEXMHUQPLBQKN35FX3

1. https://api.foursquare.com/v2/venues/explore?near=DURBAN&v=20200511&client_id=T1QHICJK4NPR3RZWWRRV3YZY5YL3QJKHVLMKRX0B1YYL0AIY&client_secret=XK0Q3KYJOSN51XTTRZDJ1JWNYOEHDXVEXMHUQPLBQKN35FX3

   https://api.foursquare.com/v2/venues/explore?ll=-29.84687587107469,31.007350219458488&v=20200511&client_id=T1QHICJK4NPR3RZWWRRV3YZY5YL3QJKHVLMKRX0B1YYL0AIY&client_secret=XK0Q3KYJOSN51XTTRZDJ1JWNYOEHDXVEXMHUQPLBQKN35FX3

2. https://api.foursquare.com/v2/venues/43695300f964a5208c291fe3/photos?&v=20200511&client_id=T1QHICJK4NPR3RZWWRRV3YZY5YL3QJKHVLMKRX0B1YYL0AIY&client_secret=XK0Q3KYJOSN51XTTRZDJ1JWNYOEHDXVEXMHUQPLBQKN35FX3

3. https://api.foursquare.com/v2/photos/51e4151c498e60b5d17bc721?v=20200511&client_id=T1QHICJK4NPR3RZWWRRV3YZY5YL3QJKHVLMKRX0B1YYL0AIY&client_secret=XK0Q3KYJOSN51XTTRZDJ1JWNYOEHDXVEXMHUQPLBQKN35FX3

