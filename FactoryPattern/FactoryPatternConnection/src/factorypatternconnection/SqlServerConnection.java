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
public class SqlServerConnection implements IConnection {
    
    public SqlServerConnection() {
    }

    @Override
    public String description() {
        return "SQL Server";
    }
    
}
