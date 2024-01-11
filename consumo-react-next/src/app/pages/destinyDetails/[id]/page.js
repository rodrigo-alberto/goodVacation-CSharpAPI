import React from 'react'
import styles from '../../../styles/destinyDetailsPage.module.css';

export default async function Details({ params }) {
    const card = await fetch(`http://localhost:5063/api/Destinys/GetDestinyById/${params.id}`).then(res => res.json());

    return (
        <section>
            <div className="row">
                <div className="col-lg-6 my-3">
                    <div className="d-flex justify-content-center">
                        <div className="card">
                            <div className={styles.cardPhoto}>
                                <img
                                    src={card.imageUrls[0]}
                                    className="card-img-top"
                                    alt="Imagem do destino"
                                />
                            </div>
                            <div className="card-body">
                                <span>
                                    ID: {card.id} | {card.city} - {card.state}
                                </span>
                                <h5 className="card-title fw-semibold">
                                    {card.name}
                                </h5>
                            </div>
                        </div>
                    </div>
                </div>

                <div className="col-lg-6 my-3">
                    <div className={`${styles.sectionTitle} pb-3 px-3`}>
                        <h3 className="fs-5 fw-semibold mb-4 ps-3">Descubra mais sobre esse destino:</h3>
                        <p>
                            {card.description}
                        </p>
                    </div>

                    <div className="mt-3 mx-3">
                        <p>Veja mais imagens do lugar:</p>

                        <div className={`${styles.carouselContainer} rounded `}>
                            <div id="carouselExample" className="carousel slide">
                                <div className="carousel-inner">
                                    <div className="carousel-item active">
                                        <img src={card.imageUrls[1]} className="d-block w-100" alt="..." />
                                    </div>
                                    <div className="carousel-item">
                                        <img src={card.imageUrls[0]} className="d-block w-100" alt="..." />
                                    </div>
                                </div>
                                <button
                                    className="carousel-control-prev"
                                    type="button"
                                    data-bs-target="#carouselExample"
                                    data-bs-slide="prev"
                                >
                                    <span className="carousel-control-prev-icon" aria-hidden="true" />
                                    <span className="visually-hidden">Previous</span>
                                </button>
                                <button
                                    className="carousel-control-next"
                                    type="button"
                                    data-bs-target="#carouselExample"
                                    data-bs-slide="next"
                                >
                                    <span className="carousel-control-next-icon" aria-hidden="true" />
                                    <span className="visually-hidden">Next</span>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    )
}