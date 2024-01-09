import Head from 'next/head'
import Script from 'next/script'
import { Poppins } from 'next/font/google'
import 'bootstrap/dist/css/bootstrap.min.css'
import './styles/globals.css'
import Footer from './components/Footer'
import Header from './components/Header'
import Hero from './pages/homePage/page'

const fontPop = Poppins({ subsets: ['latin'], weight: ['300', '400', '500', '600', '700'] })

export const metadata = {
  title: 'Good Vacation - Agency',
  description: 'Good Vacation: As melhores ofertas e planos de viagens estão aqui!',
}

export default function RootLayout({ children }) {
  return (
    <html lang="pt-br">
      <Head>
        <meta charSet="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <meta name="author" content="Rodrigo Alberto" />
        <link rel="icon" href="/favicon.ico" />
      </Head>

      <body className={fontPop.className}>
        <Header />
        <Hero />

        <main className="container">
          {children}
        </main>

        <Footer />
        <Script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" />
        <Script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.min.js" />
      </body>
    </html>
  )
}