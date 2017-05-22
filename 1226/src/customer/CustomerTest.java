package customer;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.Scanner;
import java.util.StringTokenizer;


public class CustomerTest {

    public static void main(String[] args) {
        int customerSay = 0;

        // Musteri genelbilgilerinin tutuldu degiskenler
        int id;
        String name;
        String surname;

        //National musteri bilgileri
        int licencePlateNumber;
        String occupation;

        //International musteri bilgileri
        String country;
        String city;

        String customerType;
        File dosya = new File("Customer.txt");//dosya
        Scanner file = null;
        try {
            file = new Scanner(new FileInputStream(dosya));//dosya aciliyor
        } catch (FileNotFoundException e) {
            System.out.println("Error: " + e.getMessage());
            System.exit(0);
        }
        // dosyadan ve klavyeden cekilen musteri bilgileri bu iki dizide tutuluyor
        Customer[] customerFile = new Customer[5];
        Customer[] customersKeyboard = new Customer[200];

        String temp = file.nextLine();
        StringTokenizer st = new StringTokenizer(temp, ",");
        int urun_sayisi = Integer.valueOf((String) st.nextElement());// dosyadan ilk elemani urun sayisi olarak aliyoruz

        //dosya ve klavyeden alinan musterilerinin urun degerlendirmesinin tutuldugu iki boyutlu diziler
        int[][] ratingsFile = new int[5][urun_sayisi];
        int[][] ratingsKeyboard = new int[200][urun_sayisi];

        for (int i = 0; i < customerFile.length; i++) {

            if (!file.hasNextLine()) {
                break;
            }

            while (file.hasNextLine()) {

                temp = file.nextLine();
                StringTokenizer st1 = new StringTokenizer(temp, ",");
                if (temp.startsWith("n") || temp.startsWith("i")) {
                    
                    st1.nextElement();
                    //Dosyadan customer verilerini cekiyorum
                    id = Integer.valueOf((String) st1.nextElement());
                    name = (st1.nextToken());
                    surname = (st1.nextToken());
                    if (temp.startsWith("n")) {
                        // dosyadan National musteri bilgilerini cekiyor
                        licencePlateNumber = Integer.valueOf(st1.nextToken());
                        occupation = (st1.nextToken());
                        customerFile[i] = new NationalCustomer(id, name, surname, licencePlateNumber, occupation);//National customer oluÅŸturup dosyadan cekilen verileri bu nesneye aktariliyor

                    } else if (temp.startsWith("i")) {
                        //dosyadan International customer bilgileri cekiliyor
                        country = (String) st1.nextToken();
                        city = (String) st1.nextToken();

                        customerFile[i] = new InternationalCustomer(id, name, surname, country, city);
                    }
                } else {
                    for (int j = 0; j < urun_sayisi; j++) {
                        ratingsFile[i][j] = Integer.valueOf((String) (st1.nextElement()));//her customer icin urunlerin degerleri doysadan cekilip iki boyutlu diziye atiliyor
                    }
                    break;
                }
            }
        }
        for (Customer x : customerFile) 
            System.out.println(x);//customer verileri ekrana yazdiriliyor

        file.close();
        avarage_point(ratingsFile, customerFile, urun_sayisi);

        for (int i = 0; i < customersKeyboard.length; i++) {//klavyeden veri girisinin alindigi yer
            file = new Scanner(System.in);
            
            System.out.print("Choose Customer Type i or n (Exit:E):");//customer tipi girilmesini istiyor i,n,e disinda bir karakter girilirse tekrar girilmesi isteniyor
            customerType = file.next();
            while (!customerType.equalsIgnoreCase("N") && !customerType.equalsIgnoreCase("i") && !customerType.equalsIgnoreCase("e")) {
                if (!customerType.equalsIgnoreCase("i") || !customerType.equalsIgnoreCase("n") || !customerType.equalsIgnoreCase("e")) {
                    System.out.print("Wrong Custome Type Please Choose Right Type: ");
                    customerType = file.next();
                }
            }
            if (customerType.equalsIgnoreCase("e")) {
                break;//cikis saglaniyor
            }
            customerSay++;//klavyede customer verilerini isteniyor
            System.out.print("Customer id :");
            id = file.nextInt();
            System.out.print("Customer name :");
            name = file.next();
            System.out.print("Customer surname :");
            surname = file.next();

            if (customerType.equalsIgnoreCase("N")) {//national customer icin veri istegi
                System.out.print("Licence Plate Number :");
                licencePlateNumber = file.nextInt();
                System.out.print("Occupation :");
                occupation = file.next();

                customersKeyboard[i] = new NationalCustomer(id, name, surname, licencePlateNumber, occupation);
            } else {
                //international customer icin veri istegi
                System.out.print("Country :");
                country = file.next();
                System.out.print("City :");
                city = file.next();
                customersKeyboard[i] = new InternationalCustomer(id, name, surname, country, city);
            }
            for (int j = 0; j < urun_sayisi - 1; j++) {//urun puanlari
                System.out.print((j + 1) + ". Urun puani : ");
                ratingsKeyboard[i][j] = file.nextInt();
            }
            ratingsKeyboard[i][4] = tahmin(ratingsKeyboard[i], ratingsFile);
        }
        writeKeywordCustomer(customersKeyboard, ratingsKeyboard, customerSay);
    }

    public static void avarage_point(int[][] array, Customer[] customer, int products_number) {
        double[] avarage = new double[products_number];//ortalama tutulacak diziler
        double[] avarageN = new double[products_number];
        double[] avarageI = new double[products_number];
        double[] avarageND = new double[products_number];
        int tempN = 0, tempI = 0, tempND = 0;

        for (int a = 0; a < products_number; a++) {// dizilerin sifirlanmasi
            avarage[a] = 0.0d;
            avarageN[a] = 0.0d;
            avarageI[a] = 0.0d;
            avarageND[a] = 0.0d;
        }
        System.out.println("All customer-->");
        for (int i = 0; i < products_number; i++) {
            int sayacN = 0;
            int sayacI = 0;
            int sayacND = 0;
            
            for (int j = 0; j < customer.length; j++) {
                avarage[i] = avarage[i] + array[j][i];//genel ortalama alimi
                if (customer[j] instanceof NationalCustomer) {//sadece national customerler icin ortalama alimi
                    avarageN[i] = avarageN[i] + array[j][i];
                    sayacN++;
                    NationalCustomer doctor = (NationalCustomer) customer[j];
                    if (doctor.getOccupation().equalsIgnoreCase("doktor")) {//sadece national ve doktor customer icin ortalama
                        avarageND[i] = avarageND[i] + array[j][i];
                        sayacND++;
                    }
                }
                if (customer[j] instanceof InternationalCustomer) {//international customer icin ortalama 
                    avarageI[i] = avarageI[i] + array[j][i];
                    sayacI++;
                }
            }
            tempN = sayacN;
            tempI = sayacI;
            tempND = sayacND;
            System.out.println((i + 1) + ". Urun Ortalamasi:  " + avarage[i] / customer.length);
        }

        System.out.println("National Customer-->");
        writeAvarageCustomer(avarageN, tempN);

        System.out.println("InterNational Customer-->");
        writeAvarageCustomer(avarageI, tempI);

        System.out.println("National Doctor Customer-->");
        writeAvarageCustomer(avarageND, tempND);

        writeAvarageDown(customer, array, avarage);
    }

    private static void writeAvarageCustomer(double[] avarage, int numberOfCustomer) {
        for (int i = 0; i < 5; i++) {
            System.out.println((i + 1) + ". Urun Ortalamasi :" + String.format("%.2f", avarage[i] / numberOfCustomer));
        }
    }//ortalama yazdirma

    private static void writeAvarageDown(Customer[] customer, int[][] ratings, double[] avarage) {
        for (int i = 0; i < avarage.length; i++) {
            System.out.println((i + 1) + ".Urun icin ortalama derecelendirmenin altinda puan veren musteriler :");
            for (int j = 0; j < customer.length; j++) {
                if (customer[j] instanceof NationalCustomer) {
                    NationalCustomer ntc = (NationalCustomer) customer[j];
                    if (avarage[i] / 5 > (double) ratings[j][i]) {
                        System.out.println(ntc.toString());
                    }
                }
                if (customer[j] instanceof InternationalCustomer) {
                    InternationalCustomer intc = (InternationalCustomer) customer[j];
                    if (avarage[i] / 5 > (double) ratings[j][i]) {
                        System.out.println(intc.toString());
                    }
                }
            }
        }
    }//ortalama altinda kalanlari yazdirma

    private static void writeKeywordCustomer(Customer[] customer, int[][] ratings, int cSay) {
        if (cSay != 0) {
            double[] avarage = new double[5];
            for (int i = 0; i < 5; i++) {
                avarage[i] = 0.0d;
            }
            for (int i = 0; i < cSay; i++) {
                if (customer[i] instanceof NationalCustomer) {
                    NationalCustomer nCustomer = (NationalCustomer) customer[i];
                    System.out.println(nCustomer.toString());
                }
                if (customer[i] instanceof InternationalCustomer) {
                    InternationalCustomer nCustomer = (InternationalCustomer) customer[i];
                    System.out.println(nCustomer.toString());
                }
                for (int j = 0; j < 5; j++) {
                    avarage[j] += (double) ratings[i][j] / cSay;
                }
            }
            for (int i = 0; i < 5; i++) {
                System.out.println((i + 1) + ".  Urun Ortalamasi :" + String.format("%.2f", avarage[i]));
            }
        }
    }//klavyeden alinan customerlarin yazdilirmasi

    public static int tahmin(int[] InputK, int[][] InputD) {
        int tahmin = 0;
        int benzerlik = 0;
        int min = 20;
        int sayac = 0;

        for (int[] x : InputD) {
            for (int i = 0; i < 4; i++) {
                benzerlik += Math.abs(InputK[i] - x[i]);
            }

            if (min > benzerlik) {
                min = benzerlik;
                tahmin = x[4];
                sayac = 1;
            } else if (min == benzerlik) {
                tahmin += x[4];
                sayac++;
            }
            benzerlik = 0;
        }
        return tahmin / sayac;
    }//5. urun icin tahmin etme algoritmasi
}
    

