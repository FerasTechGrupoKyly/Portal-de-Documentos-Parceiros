import styles from './Button.module.scss';
import React, { ReactFragment } from 'react';

class Button extends React.Component <{
    type?: "button";
    children?: ReactFragment | undefined;
}>{
    render(){
        const { type = "button"} = this.props;

        return(
            <button className={styles.button}>
                {this.props.children}
            </button>
        )
    }

}
export default Button;
