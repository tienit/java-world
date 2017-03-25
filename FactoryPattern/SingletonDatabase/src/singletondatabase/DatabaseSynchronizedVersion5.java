/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package singletondatabase;

/**
 *
 * @author TIENIT
 */
public class DatabaseSynchronizedVersion5 {
    
    private static DatabaseSynchronizedVersion5 singleObject = new DatabaseSynchronizedVersion5("Products");
    private int record;
    private String name;
    
    private DatabaseSynchronizedVersion5(String n) {
        this.name = n;
        this.record = 0;
    }
    
    public static synchronized DatabaseSynchronizedVersion5 getInstance(String n) {
        return singleObject;
    }
    
    public void editRecord(String operation) {
        System.out.println("Performing a " + operation + " operation on reocrd " + record + " record in database " + name);
    }
    
    public String getName() {
        return this.name;
    }
}
