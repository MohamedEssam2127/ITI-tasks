import Link from 'next/link'
 
export default function NotFound() {
  return (
    <div className="container text-center mt-5">
      <h2 className="display-4">Not Found</h2>
      <p className="lead">Could not find requested resource</p>
      <Link href="/" className="btn btn-primary">Return Home</Link>
    </div>
  )
}
