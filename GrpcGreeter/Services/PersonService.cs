
using Grpc.Core;
using Grpserver;

namespace GrpcGreeter.Services
{
    public class PersonService : person.personBase
    {
        private static IList<PersonModel> people = new List<PersonModel>()
        {
        new PersonModel() { Id =3},
        new PersonModel() { Id =5},
        new PersonModel() { Id =7},
        new PersonModel() { Id =8},
        new PersonModel() { Id =12},
        new PersonModel() { Id =14},

        };

        public override Task<PersonListModel> GetPeople(Empty request, ServerCallContext context)
        {
            var output = new PersonListModel();
            output.People.AddRange(people);
            return Task.FromResult(output);
        }

        public override Task<Result> CreatePerson(PersonModel request, ServerCallContext context)
        {
            people.Add(request);
            return Task.FromResult(new Result());
        }
        public override Task<PersonModel> Findperson(PersonProto proto, ServerCallContext context)
        {
            var result = people.Where(p => p.Id == proto.PersonId).FirstOrDefault();

            return Task.FromResult(result);

        }
        public override Task<Empty> Removeperson(PersonProto personProto, ServerCallContext context)
        {
            var result = people.Where(s => s.Id == personProto.PersonId).FirstOrDefault();
            people.Remove(result);
            return Task.FromResult(new Empty());
        }
        public override async Task<accuntoutinfo> personacountinfo(accountinfo info, ServerCallContext context)
        {
            var p = new accountinfo(info);
            var c = p.Depositeamount - p.Widrawamount;
            var h = new accuntoutinfo() { Remaning = c };
            Console.WriteLine($"your balance is {h}");
            return await Task.FromResult(h);
        }



    }
}
