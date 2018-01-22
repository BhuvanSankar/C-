using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace P3new1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IP3newWCF" in both code and config file together.
    [ServiceContract]
    public interface IP3newWCF
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<Book> GetAllBooks();

        [OperationContract]
        Boolean AddBook(string ID, string name, string author, int year, float price, int stock);

        [OperationContract]
        Boolean DeleteBook(string dropkey, string textkey);

        [OperationContract]
        List<Book> SearchBook(string dropkey, string textkey);

        [OperationContract]
        float budget(int k, int v);

       // [OperationContract]
       // BookPurchaseResponse bpr(BookPurchaseInfo bpi);


    }

    [DataContract]
    public class Book
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string author { get; set; }

        [DataMember]
        public int year { get; set; }

        [DataMember]
        public float price { get; set; }

        [DataMember]
        public int stock { get; set; }
    }

    [MessageContract]
    public class BookPurchaseInfo
    {

        [MessageBodyMember]
        public float Budget;

        [MessageBodyMember]
        public Dictionary<int, int> items = new Dictionary<int, int>();



    }

    [MessageContract]
    public class BookPurchaseResponse
    {

        public BookPurchaseResponse() { }
        public BookPurchaseResponse(bool rs, string rsp) { this.response = rsp; this.result = rs; }

        [MessageBodyMember]
        public string response;
        [MessageBodyMember]
        public bool result;
    }

}
