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
public class SecureOracleConnection extends OracleConnection {
    
    private final String pass;
    
    public SecureOracleConnection(String pass) {
        this.pass = pass;
    }
    
    @Override
    public String description() {
        if (pass.equals("tienit")) {
            return "Oracle with secure connection.";
        }
        else {
            return "Oracle but invalid password";
        }
    }
    
}
