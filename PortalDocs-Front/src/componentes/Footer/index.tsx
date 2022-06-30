import React from 'react';
import styles from './Footer.module.scss'
import {ReactComponent as Kyly} from 'assets/Kyly.svg'


export default function Footer(){
    return(
        <footer className={styles.footer}>
            <Kyly/>

        </footer>
    )
}