import { Stack, Typography, IconButton } from "@mui/material";
import FacebookIcon from '@mui/icons-material/Facebook';
import TwitterIcon from '@mui/icons-material/Twitter';
import InstagramIcon from '@mui/icons-material/Instagram';

export default function MyFooter() {
  return (
    <Stack
      direction={{ xs: 'column', md: 'row' }}
      sx={{
        bgcolor: "#303841",
        width: "100%",
        boxSizing: "border-box",
        px: { xs: 3, lg: 16 },
        py: { xs: 4, md: 3 },
        justifyContent: "space-between",
        alignItems: "center",
        gap: { xs: 2, md: 0 },
      }}
    >
      <Typography sx={{ color: "#F5F5F5", textAlign: 'center' }}>
        &copy; 2025 Restaurant. All rights reserved.
      </Typography>
      
      <Stack direction="row" spacing={1}>
        <IconButton sx={{ color: "#F5F5F5" }} aria-label="Facebook">
          <FacebookIcon />
        </IconButton>
        <IconButton sx={{ color: "#F5F5F5" }} aria-label="Twitter">
          <TwitterIcon />
        </IconButton>
        <IconButton sx={{ color: "#F5F5F5" }} aria-label="Instagram">
          <InstagramIcon />
        </IconButton>
      </Stack>
    </Stack>
  );
}
