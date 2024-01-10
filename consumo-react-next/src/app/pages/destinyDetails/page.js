import React from 'react'
import styles from '../../styles/destinyDetailsPage.module.css';

export default async function Details({ params }) {
    const card = await fetch(`http://localhost:5063/GetDestinyById/${params.id}`).then(res => res.json());

    return (
        <section>
            <h1>Opa</h1>
            <p>{card.id}</p>
            <p>{card.name}</p>
        </section>
    )
}