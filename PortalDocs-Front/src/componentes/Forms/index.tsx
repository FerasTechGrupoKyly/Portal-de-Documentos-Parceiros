import Button from 'componentes/Button';
import React from 'react';
import styles from './Forms.module.scss'
import FormsFuncionario from 'componentes/FormsFuncionarios'

class Forms extends React.Component{
    render(){
        return(
            <form className={styles.form}>
                <p className={styles.p1}>Dados da Solicitação</p>
                <div>
                    <label>Nome solicitante:</label>
                    <input type="text" name='NomeSolicitante' id='NomeSolicitante' />
                </div>
                <div>
                    <label>Data da solicitação:</label>
                    <input type='date' name='DataDaSolicitacao' id='DataDaSolicitacao' />
                </div>
                <div>
                    <label>Observação da solicitação:</label>
                    <input type='text' name='ObservacaoSolicitacao' id='ObservacaoSolicitacao'/>
                </div>
                <div>
                    <label>Documentos requeridos:</label>
                    <input type='text' name='DocumentosRequeridos' id='DocumentosRequeridos'/>
                </div>
                <div>
                    <label>Tipo de documento:</label>
                    <input type='text' name='TipoDocumento' id='TipoDocumento'/>
                </div>
                <p className={styles.p2}>Dados do Parceiro</p>
                <div>
                    <label>CNPJ:</label>
                    <input type='text' name='Cnpj' id='Cnpj'/>
                </div>
                <div>
                    <label>Nome:</label>
                    <input type='text' name='Nome' id='Nome'/>
                </div>
                <div>
                    <label>E-mail:</label>
                    <input type='text' name='Email' id='Email'/>
                </div>
                <div>
                    <label>Documentos necessarios da empresa:</label>
                    <input type='grid' name='DocumentosEmpresa' id='DocumentosEmpresa'/>
                </div>
                <p className={styles.p3}>Dados dos funcionarios</p>
                    <FormsFuncionario/>
                <Button>Enviar</Button>
            </form>
        )
    }
}
export default Forms