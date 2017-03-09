Test Cases for WebAPI



In this case: 
Happy path scenarios
1. A client should be able to GET all Cinema theater names and Id list
2. A client should be able to GET one Cinema theater by Id
3. Can two Cinemas show same movie with different availabilty
4. Is the current availability matches the actuals. 
5. Each Cinema model should include its associated movie list which includes movie Id, name and availability.
6. Should return empty list if no matching cinema for a particular Id is found. 
7. Return appropriate error response if execution fails or expected headers.
8. Test basic CRUD operations for individual or list of items.

Other scenarios:
1. Should not add two Cinemas/movies with same Id.
2. Validations like maximum string length and amount
3. Testing for maximum payload, like try fetching 100's of Cinemas with lot of movies. 
4. Measuring the response time. 
5. Testing unsupported/erroneous request


UI Side tests
1. Can populate the Cinema list with names on Pageload
2. Is movie list loaded for the default picked Cinema on pageload
3. On selecting the Cinema appropriate movie list with availability is loaded

