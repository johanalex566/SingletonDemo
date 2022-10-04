Singleton features

-At any time, only 0 or 1 instance exists in the application
-Singleton classes are created without parameters
-Assume lazy instantiation as the default 

-Must have a single, priavate, parameterless constructor
-Singleton class must have how sealed
-A private static field holds the only reference to te instace
-A public static method provides access to this field

Problem with singleton patterns

Thread Safety
	The biggest problem in multi-threaded environment, this IF block ca be reached by multiple threads
	concurrently, resulting in multiple instantiations of singleton
  
  
  
  With the help of 
  
  Undestand the concept with
  Steve Smith https://app.pluralsight.com/
  Code by 
  Code Radiance
  https://www.youtube.com/watch?v=DcbxFugk5pM&t=116s
