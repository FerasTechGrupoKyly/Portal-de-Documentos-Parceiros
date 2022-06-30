import React from 'react';
import ReactDOM from 'react-dom/client';
import 'normalize.css';
import './index.css';
import Formulario from './pages/Formulario';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <div> 
    <Formulario />
  </div>,
   
);
