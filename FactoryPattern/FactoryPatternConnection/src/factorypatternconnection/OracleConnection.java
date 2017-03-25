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
public class OracleConnection implements IConnection {
    
    public OracleConnection() {
    }

    @Override
    public String description() {
        return "Oracle";
    }
    
}
