import styles from '../../styles/homePage.module.css'

export default function Hero() {
  return (
    <section id={styles.heroSection} className="d-flex pb-4">
      <div className={`${styles.leftHeroSection} ${styles.sectionTitle} text-center align-self-center mx-4`}>
        <h1 className="py-3 mb-4">O mundo ao seu alcançe</h1>
        <p className="fs-4 fw-light">
          As melhores ofertas e planos de viagens estão aqui!
        </p>
      </div>
      <div className={`${styles.rightHeroSection} text-end`}>
        <img src="imgs/leaf2.png" />
      </div>
    </section>
  )
}