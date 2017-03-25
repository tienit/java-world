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
public class SecureSqlServerConnection extends SqlServerConnection {
    
    private final String pass;
    
    public SecureSqlServerConnection(String pass) {
        this.pass = pass;
    }
    
    @Override
    public String description() {
        if (pass.equals("tienit")) {
            return "SQL Server with secure connection.";
        }
        else {
            return "SQL Server but invalid password.";
        }
    }
}
