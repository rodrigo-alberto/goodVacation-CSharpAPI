import React from 'react'
import styles from '../styles/footer.module.css'

export default function Footer() {
  return (
    <footer className="container-fluid" id={styles.footer}>
      <div className="container">
        <div className="row">
          <div className="col-12" id={styles.footerTop}>
            <div className="row justify-content-between">
              <div className="col-6">
                <h3 className="fs-5">Good Vacation Agency</h3>
              </div>
              <div className="col-6 text-end" id={styles.socialNetworks}>
                <a href="https://www.instagram.com/" target="_blank">
                  <img src="/icons/instagram.svg" className="me-3 pt-3"></img>
                </a>
                <a href="https://www.facebook.com/" target="_blank">
                  <img src="/icons/facebook.svg" className="me-3 pt-3"></img>
                </a>
                <a href="https://www.linkedin.com/" target="_blank">
                  <img src="/icons/linkedin.svg" className="me-3 pt-3"></img>
                </a>
                <a href="https://twitter.com/" target="_blank">
                  <img src="/icons/twitter-x.svg" className="me-3 pt-3"></img>
                </a>
              </div>
            </div>
          </div>
          <div className="col-12" id={styles.footerBottom}>
            <div className="row justify-content-between">
              <div className="col-12 col-md-3">
                <p className="fw-light">Recode Pro 2023</p>
              </div>
              <div className="col-12 col-md-4">
                <p className={`${styles.autor} fw-light text-end me-3`}>
                  Desenvolvido por: <a className="fw-medium mx-1"
                    href="https://www.linkedin.com/in/rodrigo-alberto-"
                    target="_blank">Rodrigo Alberto
                  </a> © 2024
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </footer>
  )
}
