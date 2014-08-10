import Control.Concurrent
import Data.Bystring as Bystring
import GetURL

main = do
	m1 <- newEmptyMVar
		putMVar m1 r
		