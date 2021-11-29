# Kanye-RonSwansonProgram
Created a console application that calls both the Ron Swanson API, and the Kanye West API
Connectected to Http "var client = new HttpClient();"
Called string from Api "GetStringAsync(kanyeURL)" 
Assignined it to to the variable Kanye Response 
var KanyeResponse = client.GetStringAsync(kanyeURL).Result;
Created a class to consolidate work space
Used a for loop to generate at least 10 quotes from each api and have them alternate to simulate a conversation
for (int i = 0; i < 10; i++)
