import { Card, CardMedia, CardContent, Typography, CardActions, Button } from '@mui/material'
import spiderImage from '../assets/Venom.png'

export default function SpiderCard({ title }) {
  return (
    <Card sx={{ bgcolor: '#ffffffff', color: 'white', borderRadius: 1 }}>
      <CardMedia
        component="img"
        height="220"
        image={spiderImage}
        alt={title}
        sx={{ bgcolor: '#000000', objectFit: 'contain' }}
      />
      <CardContent>
        <Typography variant="h6" component="div" sx={{ mb: 0.5  , color:'black'}}>
          {title}
        </Typography>
        <Typography variant="body2" sx={{ color: '#000000ff' }}>
          Creative modern UI design with hover animation.
        </Typography>
      </CardContent>
      <CardActions sx={{ display: 'block', px: 2, pb: 2, pt: 0 }}>
        <Button
          fullWidth
          variant="contained"
          sx={{
             backgroundImage: 'linear-gradient(45deg, #00d4ff 30%, #9c27b0 90%)',
            color: 'white',
            fontWeight: 'bold',
          }}
        >
          EXPLORE
        </Button>
      </CardActions>
    </Card>
  )
}