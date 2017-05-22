
package customer;


public class Customer {
        //her musteri icin gerekli bilgiler
    private int CustomerID; 
    private String Name; 
    private String Surname; 
    
    //otomatik olusturdugumuz get ve set methodlari
    public int getCustomerID() {
        return CustomerID;
    }

    public void setCustomerID(int CustomerID) {
        this.CustomerID = CustomerID;
    }

    public String getName() {
        return Name;
    }

    public void setName(String Name) {
        this.Name = Name;
    }

    public String getSurname() {
        return Surname;
    }

    public void setSurname(String Surname) {
        this.Surname = Surname;
    }
    
    
    public Customer(){ //parametresiz constructor
        //default degerleri
        CustomerID=1;
        Name="no name";
        Surname="no name";
    }
    
    public Customer(int CustomerID, String Name, String Surname){ //tum degiskenleri kullanan constructor
        this.CustomerID=CustomerID;
        this.Name=Name;
        this.Surname=Surname;
    }
    
    public Customer(Customer customer){ //copy constructor
        CustomerID=customer.CustomerID;
        Name=customer.Name;
        Surname=customer.Surname;
    }
    
    
    public String toSting(){
        return ("   CustomeID:" +CustomerID+ "\n   Customer Name:" +Name+ "\n   Customer Surname:" +Surname);
    }
    
    
    
}