
using Grpc.Net.Client;
using Grpserver;



var channel = GrpcChannel.ForAddress("https://localhost:7085");
var personService = new person.personClient(channel);
await personService.CreatePersonAsync(new PersonModel() { FirstName = "ahmad", LastName = "rahimi", IsAlive = true, Age = 55, Id = 9 });
await personService.CreatePersonAsync(new PersonModel() { FirstName = "Akbar", LastName = "Ahmadi", IsAlive = true, Age = 44, Id = 2 });
//var result = await personService.FindpersonAsync(new PersonProto() { PersonId = 12 });
//Console.WriteLine($"Person's age: {result.Age}");
await personService.RemovepersonAsync(new PersonProto() { PersonId = 14 });


