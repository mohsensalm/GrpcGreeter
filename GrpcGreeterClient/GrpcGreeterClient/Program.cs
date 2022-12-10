
using Grpc.Net.Client;
using Grpserver;
using System.Security.Principal;

var d=Account.deposit();
var w=Account.widraw();
var proto= new accountinfo() { Widrawamount =w.Result , Depositeamount = d.Result};
var channel = GrpcChannel.ForAddress("https://localhost:7085");
var personService = new person.personClient(channel);
var p = personService.personacountinfo(proto);
//await personService.CreatePersonAsync(new PersonModel() { FirstName = "ahmad", LastName = "rahimi", IsAlive = true, Age = 55, Id = 9 });
//await personService.CreatePersonAsync(new PersonModel() { FirstName = "Akbar", LastName = "Ahmadi", IsAlive = true, Age = 44, Id = 2 });
////var result = await personService.FindpersonAsync(new PersonProto() { PersonId = 12 });
////Console.WriteLine($"Person's age: {result.Age}");
//await personService.RemovepersonAsync(new PersonProto() { PersonId = 14 });


