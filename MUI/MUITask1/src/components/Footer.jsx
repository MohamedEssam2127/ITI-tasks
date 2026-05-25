import { Box, Typography } from "@mui/material";

function Footer() {
  return (
    <Box
      sx={{
        display: "block",
        textAlign: "center",
        backgroundColor: "#121212",
        padding: "30px 20px",
        width: "100%",
        boxSizing: "border-box"
      }}
    >
      <Typography
        variant="body1"
        sx={{
          display: "block",
          color: "#e0e0e0"
        }}
      >
        © 2026 SpiderUI - Built with ❤️ using MUI
      </Typography>
    </Box>
  );
}

export default Footer;
