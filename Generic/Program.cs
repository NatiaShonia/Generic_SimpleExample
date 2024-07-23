Account<int> acc1 = new Account<int>();
acc1.ID = 45;


Account<string> acc2 = new Account<string>();
acc2.ID = "4567";

Account<int> acc3 = new Account<int>();
acc3.ID = 12;

Console.WriteLine($"acc1 : {acc1.ID}, acc2 : {acc2.ID}");




Transaction<int, string> transaction1 = new Transaction<int, string>()
{
    FromAccount = 12,
    ToAccount = 24,
    Operation = "15"
};

Transaction<Account<int>, string> transaction2 = new Transaction<Account<int>, string>()
{
    FromAccount = acc1,
    ToAccount = acc3,
    Operation = "123"
};

Console.WriteLine($"Transaction1_from account {transaction1.FromAccount}");
Console.WriteLine($"Transaction2_from account {transaction2.FromAccount.ID}");


//Generic
class Account<T>
{
    public T ID { get; set; }   //უნიკალური იდენთიფიკატორი, ამ შემთხვევაში ანგარიშს ნომერი  

    public decimal Balance { get; set; }   //თანხის ის რაოდენობა რომელიც დევს ანგარიშზე


}


class Transaction<U, V>                           //ეს კლასი პასუხისმგებელია ერთუ ანგარიშიდან მეორეზე თანხის გადატანაზე
{
    public U FromAccount { get; set; }            //საიდანაც ხდება გადარიცხვა, ვისგანაც ხდება
    public U ToAccount { get; set; }              //სადაც ხდება გადარიცხვა 
    public V Operation { get; set; }             //განხორციელებული ტრანზაქციის კოდი

}





