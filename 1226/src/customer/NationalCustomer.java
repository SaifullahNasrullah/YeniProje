
package customer;


public class NationalCustomer extends Customer {
        //ulusal musteriye ozel bilgiler 
    private int LicencePlateNumber; 
    private String Occupation; 
    
    //otomatik getter ve setter 
    public int getLicencePlateNumber() {
        return LicencePlateNumber;
    }

    public void setLicencePlateNumber(int LicencePlateNumber) {
        this.LicencePlateNumber = LicencePlateNumber;
    }

    public String getOccupation() {
        return Occupation;
    }

    public void setOccupation(String Occupation) {
        this.Occupation = Occupation;
    }
    
    public NationalCustomer(){ //parametresiz constructor
        super(); //customer sinifindaki parametresiz constructor default bilgilerini iceren method
        //default degerler
        LicencePlateNumber=1;
        Occupation="no occupation";
    }
    
    public NationalCustomer(int theCustomerID, String theName, String theSurname, int LicencePlateNumber, String Occupation){ //tum parametreleri alan constructor
        super(theCustomerID, theName, theSurname); //customer sinifinda tum parametreleri alan constructor bilgilerini iceren method..
        this.LicencePlateNumber=LicencePlateNumber;
        this.Occupation=Occupation;
    }
    
    public NationalCustomer(NationalCustomer nationalCustomer){ //copy constructor
        super(nationalCustomer); //customer sinifinda copy constructor bilgilerini iceren method..
        LicencePlateNumber=nationalCustomer.LicencePlateNumber;
        Occupation=nationalCustomer.Occupation;
    }
    
    @Override
    public String toString(){
        return ("National Customer's Infotmation-->\n" +super.toSting()+
                "\n   Licemce Plate Number:" +LicencePlateNumber+ " \n   Occupation:" +Occupation+"\n");
                
    }
}
