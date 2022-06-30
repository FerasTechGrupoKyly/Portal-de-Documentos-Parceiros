import Button from 'componentes/Button';
import React from 'react';
import styles from './Modal.module.scss'

const Modal = ({id = 'modal', onClose = () => {}, children}) => {
 
    const handleOutSideClick = (e) => {
        if(e.target.id == id) onClose()
    };

return(
    <div id="modal" className={styles.modal} onClick={handleOutSideClick}>
        <div className={styles.container}>
            <button className={styles.close} onClick={onClose}/>
            <div className={styles.content}>{children}</div>
            
            
        </div>
    </div>
)
}
export default Modal;