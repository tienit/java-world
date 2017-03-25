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
public class MySqlConnection implements IConnection {

    public MySqlConnection() {
    }
    
    @Override
    public String description() {
        return "My SQL";
    }
    
}
