import React from 'react'
import styles from '../styles/header.module.css'
import Link from 'next/link'

export default function Header() {
  return (
    <header>
      <nav className="navbar navbar-expand-lg" id={styles.navbar}>
        <div className="container-fluid">
          <a className="navbar-brand d-flex align-items-center" href="index.html">
            <img src="/imgs/logo.png" alt="logo" />
            <span className="me-2 fw-semibold">Good Vacation</span>
          </a>
          <button
            className="navbar-toggler"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon" />
          </button>
          <div className="collapse navbar-collapse" id="navbarSupportedContent">
            <ul className="navbar-nav me-auto mb-2 mb-lg-0">
              <li className={`${styles.navUtilities} nav-item me-2`}>
                <div className={`${styles.accountBox} rounded-bottom py-1`}>
                  <Link
                    href="../"
                    className="nav-link d-flex align-items-center text-decoration-none pt-2 px-2"
                  >
                    <img
                      src="/icons/house.svg"
                      className="rounded-circle me-2 p-1 border border-1"
                      alt="Home"
                    />
                    <span>Home</span>
                  </Link>
                </div>
              </li>
              <li className={`${styles.navUtilities} ms-0`}>
                <div className={`${styles.accountBox} rounded-bottom py-1`}>
                  <Link
                    href="../pages/destinys"
                    className="nav-link d-flex align-items-center text-decoration-none pt-2 px-2"
                  >
                    <img
                      src="/icons/suitcase-fill.svg"
                      className="rounded-circle me-2 p-1 border border-1"
                      alt="Destinos"
                    />
                    <span>Conheça nossos destinos!</span>
                  </Link>
                </div>
              </li>
            </ul>
            <div className={`${styles.navHelp} ms-3 ps-2`}>
              <a
                className="nav-link fs-6"
                href="#"
              >
                Ajuda
                <button className="btn btn-outline-primary rounded-circle ms-3" type="submit">?</button>
              </a>
            </div>
          </div>
        </div>
      </nav>
    </header>
  )
}