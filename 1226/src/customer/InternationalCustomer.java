
package customer;


public class InternationalCustomer extends Customer{
    //uluslarasi musteriye ozel bilgiler
    private String Country;
    private String City;
    
    //otomatik getter ve setter 
    public String getCountry() {
        return Country;
    }

    public void setCountry(String Country) {
        this.Country = Country;
    }

    public String getCity() {
        return City;
    }

    public void setCity(String City) {
        this.City = City;
    }
    
    public InternationalCustomer(){ //parametresiz constructor
        super(); //customer sinifindaki parametresiz constructor default bilgilerini iceren method
        //default degerler
        Country="no country";
        City="no city";
    }
    
    public InternationalCustomer(int theCustomerID, String theName, String theSurname, String Country, String City){ //tum parametreleri alan constructor
        super(theCustomerID, theName, theSurname); //customer sinifinda tum parametreleri alan constructor bilgilerini iceren method..
        this.Country=Country;
        this.City=City;
    }
    
    public InternationalCustomer(InternationalCustomer internationalCustomer){ //copy constructor..
        super(internationalCustomer); //customer sinifinda copy constructor bilgilerini iceren method..
        Country=internationalCustomer.Country;
        City=internationalCustomer.City;
    }
    
    @Override
    public String toString(){
        return ("International Customer's Information -->\n"+super.toSting()+"\n   Country:" +Country+ "\n   City:" +City+"\n");
    }
    
}
