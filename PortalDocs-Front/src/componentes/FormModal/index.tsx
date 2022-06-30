import Button from 'componentes/Button';
import React from 'react';
import styles from './FormModal.module.scss'
import {ReactComponent as Logo} from 'assets/logo.svg'
export default function FormModal(){
    return(
        <main className={styles.main}>
            <header className={styles.header}>
                <h2 className={styles.header_text}>Preencha os campos a baixo</h2>
            </header>
            <form className={styles.form}>
                <div>
                    <label>Nome Funcionario</label>
                    <input type='text' name='NomeFuncionario' id='NomeFuncionario'/>
                </div>
                <div>
                    <label>RG</label>
                    <input type='text' name='RgFuncionario' id='RgFuncionario'/>
                </div>
                <div>
                    <label>CPF</label>
                    <input type='text' name='CpfFuncionario' id='CpfFuncionario'/>
                </div>
                <div>
                    <label>Documentos do Funcionario</label>
                    <input type='text' name='DocumentosFuncionario' id='DocumentosFuncionario'/>
                </div>
                <div className={styles.button}>
                    <Button>Salvar</Button>
                </div>

                
            </form>
            <footer>
                <Logo/>
            </footer>

        </main>
    )
}