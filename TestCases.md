<p><h2>Test Cases</h2></p>

<p>
<ul>
<h4>For WebAPI</h4>
<h4>Happy path scenarios</h4>
<li>A client should be able to GET all Cinema theater names and Id list</li>
<li>A client should be able to GET one Cinema theater by Id</li>
<li>Can two Cinemas show same movie with different availabilty</li>
<li>Is the current availability matches the actuals. </li>
<li>Each Cinema model should include its associated movie list which includes movie Id, name and availability.</li>
<li>Should return empty list if no matching cinema for a particular Id is found. </li>
<li>Return appropriate error response if execution fails or expected headers.</li>
<li>Test basic CRUD operations for individual or list of items.</li>
</ul>
</p>
<p>
<ul>
<h4>Other scenarios:</h4>
<li>Should not add two Cinemas/movies with same Id.</li>
<li>Validations like maximum string length and amount</li>
<li>Testing for maximum payload, like try fetching 100's of Cinemas with lot of movies. </li>
<li>Measuring the response time. </li>
<li>Testing unsupported/erroneous request</li></ul></p>

<p>
<ul>
<h4>UI Side tests</h4>
<li>Can populate the Cinema list with names on Pageload</li>
<li>Is movie list loaded for the default picked Cinema on pageload</li>
<li>On selecting the Cinema appropriate movie list with availability is loaded</li></ul></p>

