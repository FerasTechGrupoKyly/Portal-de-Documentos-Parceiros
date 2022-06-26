import React from 'react';
import styles from './Forms.module.scss'

class Forms extends React.Component{
    render(){
        return(
            <form className={styles.form}>
                <p className={styles.p1}>Dados da Solicitação</p>
                <div>
                    <label>Nome solicitante</label>
                    <input type="text" name='Nome Solicitante' id='nome solicitante' />
                </div>
                <div>
                    <label>Data da solicitação</label>
                    <input type='string' name='data da solicitação' id='data da solicitação' />
                </div>
            </form>
        )
    }
}
export default Forms