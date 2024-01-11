import React from 'react'
import styles from '../styles/cardDestiny.module.css';
import Link from 'next/link';

export default async function CardDestiny() {
    const cards = await fetch('http://localhost:5063/api/Destinys/GetAllDestinys').then(res => res.json());
    const MIN_DESTINATIONS_RENDER = 4;

    return (
        <div className={`${styles.cardBoxDestinations} d-flex flex-wrap align-items-center justify-content-center`}>
            {cards.length >= MIN_DESTINATIONS_RENDER ? (
                cards?.map((card) => (
                    <div className={`${styles.cardDestinations} card`}>
                        <img src={card.imageUrls[0]} className="card-img-top" alt="Imagem do destino" />
                        <div className="card-body">
                            <span>PASSAGEM</span>
                            <h5 className="card-title fw-semibold">{card.name}</h5>
                            <p className={styles.cardText}>Voo saindo de São Paulo</p>
                            <span className={styles.cardTag}>Ida e volta</span>
                        </div>
                        <ul className="list-group list-group-flush">
                            <li className="list-group-item">
                                <div className={styles.cardBottom}>
                                    <p>{card.city} - {card.state}</p>
                                    <Link
                                        href={{
                                            pathname: `../pages/destinyDetails`,
                                            query: { id: card.id },
                                        }}
                                        as={`../pages/destinyDetails/${card.id}`}
                                        className="text-decoration-none"
                                    >
                                        <span className="btn-outline-primary border rounded-circle">+</span>
                                    </Link>
                                </div>
                            </li>
                        </ul>
                    </div>
                ))
            ) : (
                <>
                    <p>Não há destinos suficientes cadastrados para exibir :(</p>
                </>
            )}
        </div>
    )
}