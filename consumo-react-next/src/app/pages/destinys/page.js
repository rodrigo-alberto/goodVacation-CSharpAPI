import React from 'react'
import styles from '@/app/styles/destinyPage.module.css'
import CardDestiny from '@/app/components/CardDestiny'

export default function Destinys() {
  return (
    <section>
      <div className={`${styles.sectionTitle} text-center py-3 px-3`}>
        <h2>Viaje pelos nossos principais destinos!</h2>
        <p>
          Conheça novas culturas, conecte-se com a natureza ou passeie por grandes
          cidades. Tudo com os melhores preços.
        </p>
        <hr />
      </div>

      <CardDestiny />

      <div className="pt-2 text-center">
        <hr />
        <p className="mt-4 mb-3">Continue explorando lugares</p>
        {/* <button type="button" className="btn btn-outline-primary btn-md">
          Veja mais destinos
        </button> */}
      </div>
    </section>
  )
}