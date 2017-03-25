/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package factorypatternconnection;

/**
 *
 * @author TIENIT
 */
public class SecureMySqlConnection extends MySqlConnection {
    
    private final String pass;
    
    public SecureMySqlConnection(String pass) {
        this.pass = pass;
    }
    
    @Override
    public String description() {
        if (pass.equals("tienit")) {
            return "My SQL with secure connection.";
        }
        else {
            return "My SQL but invalid password.";
        }
    }
    
}
