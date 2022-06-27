import React from 'react';

export default function Lista(){
    const funcionarios = [{
        Nome:'func 1',
        RG:'123456789',
        cpf:'852874196325'
    },{
        Nome:'func 2',
        RG:'123456787',
        cpf:'852874196345'
    }]
    return(
        <aside>
            <h2>Lista de Funcionarios</h2>
            <ul>
                {funcionarios.map((item, index) =>(
                 <li>
                    <p>{item.Nome}</p>
                    <p>{item.RG}</p>
                    <p>{item.cpf}</p>
                </li>
                )
                
                )}
               
            </ul>
        </aside>
    )
}