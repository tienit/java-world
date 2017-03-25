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
public class SingletonDatabase implements Runnable {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
//        Database one = Database.getInstance("Products");
//        one.editRecord("Add");
//        
//        one = Database.getInstance("Products Also");
//        one.editRecord("Update");
//        
//        one = Database.getInstance("Products Again");
//        one.editRecord("Delete");

        //Test synchronized singleton
        
        SingletonDatabase t = new SingletonDatabase();

    }
    
    Thread thread;
    
    public SingletonDatabase() {
        
        DatabaseSynchronizedVersion5 database;
        
        database = DatabaseSynchronizedVersion5.getInstance("Products");
        
        thread = new Thread(this, "second");
        thread.start();
        
        System.out.println("This is the " + database.getName() + " database.");
    }

    @Override
    public void run() {
        DatabaseSynchronizedVersion5 database = DatabaseSynchronizedVersion5.getInstance("Employees");
        System.out.println("This is the " + database.getName() + " database.");
    }
    
}
