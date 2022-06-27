import Button from 'componentes/Button';
import Lista from 'componentes/Lista';
import React from 'react';
import styles from './FormsFuncionario.module.scss'

class FormsFuncionario extends React.Component{
    render(){
        return(
            <form>
                <fieldset className={styles.fieldset}>
                    <div>
                        <label>Nome funcionario</label>
                        <input type='text' name='NomeFuncionario' id='Nomefuncionario'/>
                    </div>
                    <div>
                        <label>RG</label>
                        <input type='text' name='RG' id='RG'/>
                    </div>
                    <div>
                        <label>CPF</label>
                        <input type='text' name='CPF' id='CPF'/>
                    </div>
                    <Lista/>
                    <Button>Salvar</Button>
                </fieldset>
               
            </form>
        )
    }
}
export default FormsFuncionario;