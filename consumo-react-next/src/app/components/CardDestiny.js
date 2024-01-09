import React from 'react'
import styles from '../styles/cardDestiny.module.css';

export default async function CardDestiny() {
    // const cards = await fetch('http://localhost:5063/api/Destinys').then(res => res.json());
    // const cards = await fetch('http://localhost:5063/GetAllDestinys').then(res => res.json());
    // console.log(cards);

    return (

        <div className={`${styles.cardBoxDestinations} d-flex flex-wrap align-items-center justify-content-center`}>
            <div className={`${styles.cardDestinations} card`}>
                <img src="../imgs/salvador.jpg" className="card-img-top" alt="Imagem do destino" />
                <div className="card-body">
                    <span>PASSAGEM</span>
                    <h5 className="card-title fw-semibold">Salvador</h5>
                    <p className={styles.cardText}>Voo saindo de São Paulo</p>
                    <span className={styles.cardTag}>Ida e volta</span>
                </div>
                <ul className="list-group list-group-flush">
                    <li className="list-group-item">
                        <div className={styles.cardBottom}>
                            <p>A partir de</p>
                            <p>
                                R$<span>570,00</span>
                            </p>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    )
}