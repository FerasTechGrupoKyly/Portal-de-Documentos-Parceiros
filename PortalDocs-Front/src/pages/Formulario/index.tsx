import styles from './Formulario.module.scss'
import {ReactComponent as Logo} from 'assets/logo.svg'
import Button from 'componentes/Button'
import Forms from 'componentes/Forms'

export default function Formulario(){
  return(
    <main>
      <nav className={styles.menu}>
        <Logo/>
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
      </form>
    </main>
  
  )
}