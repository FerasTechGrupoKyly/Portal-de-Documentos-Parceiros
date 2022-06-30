import styles from './Formulario.module.scss'
import {ReactComponent as Logo} from 'assets/logo.svg'
import Button from 'componentes/Button'
import Forms from 'componentes/Forms'
import Footer from 'componentes/Footer'
import { useState } from 'react'
import Modal from 'componentes/Modal/Modal';
import FormModal from 'componentes/FormModal'




export default function Formulario(){

  const [isModalVisible, setIsModalVisible] = useState(false)
  
  return(
    <main>
        <nav className={styles.menu}>
          <Logo />
          <div className={styles.buttons}>
            <Button>Home</Button>
            <Button>Contato</Button>
          </div>
        </nav>
        <header className={styles.header}>
          <div className={styles.header_text}>Envio de Documentos</div>

        </header>
        <form>
          <Forms />
          <button className={styles.button}
            onClick={() => setIsModalVisible(true)}>
              Adiciona Funcionario   
          </button>
            {isModalVisible ? 
             <Modal onClose={() => setIsModalVisible(false)}>
                <h2><FormModal/></h2>
              </Modal>: null}
          <Button>Enviar</Button>
        </form>
        <Footer />
      </main>
   
  )
}