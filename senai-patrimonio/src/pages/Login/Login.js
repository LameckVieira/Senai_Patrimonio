import React, { useState } from 'react'
import axios from 'axios'

import '../../assets/css/login.css'
import logo from '../../assets/img/Logo_SENAI_PRINCIPAL_VERMELHO.png'

function Login() {
  const [email, setEmail] = useState('')
  const [senha, setSenha] = useState('')
  const [errorMessage, setErrorMessage] = useState('')
  const [isLoading, setIsLoading] = useState(false)

  const login = event => {
    event.preventDefault()
    setErrorMessage('')
    setIsLoading(true)

    axios
      .post('http://localhost:5000/api/login', {
        email: email,
        senha: senha
      })
      .then(response => {
        if (response.status === 200) {
          localStorage.setItem('usuario-login', response.data.token)
          setIsLoading(false)         
        }
      })
      .catch(() => {
        setErrorMessage('E-mail e/ou senha inválido(s)! Tente novamente')
        setIsLoading(false)
      })
  }

  return (
    <div className="login_div">
      <section>
        <div className="div_img">
          <img id="logo" src={logo} alt="Logo do Senai" />
        </div>

        <div>
          <h1 id="h1-login">Login</h1>
        </div>

        <form onSubmit={login}>
          <div className="login_inputs">
            <input
              className="inputt_login"
              required
              type="text"
              name="email"
              value={email}
              onChange={event => setEmail(event.target.value)}
              placeholder="nome"
            />
            <input
              className="input_login"
              required
              type="password"
              name="senha"
              value={senha}
              onChange={event => setSenha(event.target.value)}
              placeholder="senha"
            />
          </div>

          <span>{errorMessage}</span>
          {isLoading === true ? (
            <div id="btn-login">
              <button className="button_login" disabled>
                Loading..
              </button>
            </div>
          ) : (
            <div id="btn-login">
              <button
                className="button_login"
                disabled={email === '' || senha === '' ? 'none' : ''}
              >
                Login
              </button>
            </div>
          )}
        </form>
      </section>
    </div>
  )
}

export default Login
